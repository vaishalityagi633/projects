# projects
# Azure DevOps CI/CD Project (Without Containers)

## Overview
End-to-end CI/CD pipeline using Azure DevOps to build and deploy a .NET application to a Linux VM without using containers.

## Tools Used
- Azure DevOps Pipelines
- Azure Repos / GitHub
- .NET 6
- Linux VM
- systemd
- SSH Service Connection

## CI/CD Flow
1. Code push triggers Azure DevOps pipeline
2. Application is built and published
3. Artifacts are stored in Azure DevOps
4. Files are copied to Linux VM using SSH
5. Application service is restarted using systemd

## Key Learnings
- YAML-based CI/CD pipelines
- Artifact management
- Secure SSH deployments
- VM-based application hosting
- Jenkins to Azure DevOps migration approach
