# Deployment Azure infrastructure

## Prerequisites
* [Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli)
* Visual Studio Code
    * [Bicep](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-bicep)

## Deployments
1. Definitions
    ```bash
    resourceGroupName="browser-demo-rg"
    location="japaneast"
    subscriptionId="a30fb871-b993-46f7-bb01-34026b27df08"
    ```

1. Login to Azure CLI
    ```bash
    az login
    az account set --subscription $subscriptionId
    ```

1. Create resource group
    ```bash
    az group create --name $resourceGroupName --location $location
    ```

1. Diff
    ```bash
    az deployment group what-if --resource-group $resourceGroupName --mode Complete --result-format FullResourcePayloads --template-file deploy/main.bicep
    ```

1. Deploy
    ```bash
    az deployment group create --resource-group $resourceGroupName --mode Complete --template-file deploy/main.bicep --name 1
    ```

1. Delete
    ```bash
    az group delete -n $resourceGroupName --yes
    ```
