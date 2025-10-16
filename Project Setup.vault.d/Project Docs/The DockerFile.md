## 🐳 What is a Dockerfile?

A **[[DockerFile]]** is a **plain text file with instructions** on how to build a **custom Docker image**.

- A **Docker image** is like a **snapshot of a container** — it contains everything your app needs: code, libraries, dependencies, and runtime.
    
- The DockerFile tells Docker **step by step how to assemble this image**.

### 🔹 How It Works

When you run:
```bash
docker build -t my-backend ./backend
```

Docker reads your `./backend/Dockerfile` and executes the instructions **line by line**, producing an image called `my-backend`.

Later, you can run a container from that image:
```bash
docker run -p 3000:3000 my-backend
```

### 🔹 Minimal Example for Node.js Backend

`./backend/Dockerfile`:
```dockerfile
# 1 Use official Node.js image as base
FROM node:latest

# 2 Set working directory inside container
WORKDIR /usr/src/app

# 3 (OPT) Copy package.json and install dependencies
COPY package*.json ./
RUN npm install

# 4 Copy application code
COPY . .

# 5 Expose backend port
EXPOSE 3000

# 6 Default command to start the app
CMD ["node", "index.js"]

```

**Step-by-step explanation**:

1. The first line, `FROM node:latest`, sets the base image. This means your container starts with a pre-configured Node.js environment running on the latest version. You don’t need to manually install Node, and it ensures consistency across machines. The next line, 
    
2. `WORKDIR /usr/src/app`, sets the working directory inside the container. All subsequent commands, like copying files or running commands, are executed relative to this folder. This keeps your application organized and ensures the container’s file structure is predictable.
    
3. `COPY package*.json ./` copies the `package.json` and `package-lock.json` files into the working directory. This is done separately from copying the rest of the code because Docker caches layers. By installing dependencies first, rebuilds are faster when only your app code changes. `RUN npm install` then installs all Node.js dependencies listed in those files. This ensures the container has everything needed to run the app without relying on local installations. 
>[!tip] A bit more in depth...
>Technically, this line is **optional**, but in practice it’s strongly recommended. Here’s why:
>If you skip copying the `package.json` and `package-lock.json` first and just copy all your code at once with `COPY . .`, `npm install` will still work, but you lose one of Docker’s key performance features: **layer caching**.
   >
> Docker builds images layer by layer. When you copy `package.json` separately and run `npm install`, that layer is cached. If later you only change your application code and not your dependencies, Docker can reuse the cached `npm install` layer instead of reinstalling everything. This makes rebuilds much faster.
   > 
> If you skip it and copy all files at once, any code change will invalidate the cache, and `npm install` will run again on every build, even if your dependencies haven’t changed.
   > 
> So while it’s optional in terms of functionality, keeping it improves **build speed and efficiency**.
    
1. After that, `COPY . .` copies all remaining application code into the container, so the container contains the full app.
    
2. `EXPOSE 3000` declares that the app will listen on port 3000, which Docker Compose or `docker run -p` can map to your host machine. Finally, `CMD ["node", "index.js"]` defines the default command to execute when the container starts. Without this, the container would start and immediately exit. This command ensures that your Node.js app runs automatically when the container launches.
    
3. Finally, `CMD ["node", "index.js"]` defines the default command to execute when the container starts. Without this, the container would start and immediately exit. This command ensures that your Node.js app runs automatically when the container launches.