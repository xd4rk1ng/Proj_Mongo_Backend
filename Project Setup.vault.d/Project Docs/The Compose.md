 `docker-compose.yaml`:
```yaml

services:
  # 🟢 MongoDB Service
  mongo:
    image: mongo:latest                # Official MongoDB image
    container_name: mongo_database
    ports:
      - "27017:27017"                  # Mongo Port
    volumes:
      - ./data:/data/db                # Persist DB data locally
    environment:                       # For root DB user setup
      MONGO_INITDB_ROOT_USERNAME: root
      MONGO_INITDB_ROOT_PASSWORD: atec123
    networks:
      - backend-network

  # 🟣 Node.js Backend Service
  backend:
    build: ./backend                   # Builds from local Dockerfile in backend/
    container_name: node_backend
    ports:
      - "3000:3000"                    # Backend port
    environment:
      MONGO_URI: mongodb://root:atec123@mongo:27017/ # sets Node connection to DB
      NODE_ENV: development
    depends_on:
      - mongo                          # Ensures Mongo starts first
    networks:
      - backend-network
    volumes:
      - ./backend:/usr/src/app         # Mount local code for live edits (optional)

# 🌐 Shared Network for Communication
networks:
	backend-network:                   # Name of the shared network
	    driver: bridge


```
---
## **FAQ**:
### **Backend Environment Variables**

```yaml
backend:
...
    environment:
      MONGO_URI: mongodb://root:atec123@mongo:27017/ # sets Node connection to DB
      NODE_ENV: development
```
>These are **environment variables** — small key-value pairs that configure how your app behaves **without changing the source code**.
###### *MONGO_URI*
This is a **connection string** that tells your Node.js app how to reach the MongoDB server.
Inside the backend container, your app can connect to MongoDB simply using this variable — no need for IPs or localhost.


In your Node.js code, you’d typically do something like:
``` js
import mongoose from "mongoose";
mongoose.connect(process.env.MONGO_URI);
```

That means your backend’s connection target can be changed just by editing the `.env` file or Compose config — no code edits needed.


###### *NODE_ENV*
This tells Node.js **what mode** your app is running in — usually `"development"`, `"production"`, or `"test"`.

| **Mode**      | <u>**Purpose**</u>   | **Behavior**                                                                |
| ------------- | -------------------- | --------------------------------------------------------------------------- |
| `development` | Local development    | Shows detailed errors, logs, and enables live reloads                       |
| `production`  | Deployed environment | Optimizes performance, hides stack traces, caches views, disables dev tools |
| `test`        | Automated tests      | Used by test runners like Jest or Mocha                                     |
So:
``` yaml
NODE_ENV: development
```
means your app will:
    Log more information
    Reload faster
    Skip production-only optimizations

### **Node.js build directory**

```yaml
  backend:
    build: ./backend  
```

###### *build: (instead of image)*
Tells Docker Compose to **build a custom image** for this service. Unlike `image: mongo:latest` (which just pulls an existing image from Docker Hub), `build:` creates a new image from your **[[The DockerFile| local DockerFile]]**.
        
###### *./backend*
This is the **path to the folder containing your** `DockerFile` and your Node.js source code.
Docker Compose looks inside `./backend` for a file named `Dockerfile`.
The `DockerFile` contains instructions on how to build your Node.js image (e.g., install Node, copy code, run `npm install`).