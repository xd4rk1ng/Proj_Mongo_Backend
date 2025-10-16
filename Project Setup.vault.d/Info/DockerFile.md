### 🔹 Core Concepts in a Dockerfile

**Dockerfile syntax**

|Instruction|Purpose|
|---|---|
|`FROM`|Sets the **base image** (e.g., Node.js, Python, Ubuntu). This is your starting point.|
|`WORKDIR`|Sets the **working directory** inside the container. All commands run relative to this folder.|
|`COPY`|Copies files from your host machine into the image.|
|`RUN`|Executes a command **during the build** (e.g., `npm install`).|
|`ENV`|Sets environment variables inside the container.|
|`EXPOSE`|Tells Docker which port the container will listen on (for documentation).|
|`CMD`|Specifies the **default command** when the container starts (e.g., `node index.js`).|
