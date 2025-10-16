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