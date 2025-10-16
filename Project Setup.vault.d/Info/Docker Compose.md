## 🧩 What Is Docker Compose?

### 🧠 Simple Definition

**Docker Compose** is a tool that lets you **define and run multiple containers together** using a single configuration file (`docker-compose.yml`).

Instead of manually running many `docker run` commands for each service, Compose lets you describe your entire setup — databases, APIs, networks, volumes — in one file, then start everything at once with:
```bash
docker compose up
```

### ⚙️ Why It Exists

When developing modern applications, you often have multiple components:

- A **backend** (e.g., Node.js or Python)
    
- A **database** (e.g., MongoDB or PostgreSQL)
    
- Optional extras (e.g., Redis, frontend, test service)
    

Managing each container manually is tedious.  
**Docker Compose** automates that orchestration, defining how containers:

- **Build and start**
    
- **Communicate** via shared networks
    
- **Share data** via volumes
    
- **Start in the right order**