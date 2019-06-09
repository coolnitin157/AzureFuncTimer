# AzureFuncTimer
The repo contains two folders 

1)IACFunc 
2)TimerFunc

IACFunc is IAC-Infrastructure as code for Azure function infra setup on cloud, basically you can say its like a container or holder to support the actual azure function, which will have your code to run on some trigger. In the IAC script ~/IACFunc/azuredeploy.json file we have included below component to be created autmatically 

```
1.Storage account 
2.App service plan 
3.Azure Function 
```
Parameter need to be passed
```
storageAccountName: Name(lowercase) of blob storage, this is essential as Azure function will place its files here
functionAppName: Name of azure function
cronTimerExpression: timer expression like 0 0 2 * * mon
appServicePlanName: app service plan name to be created
```

TimerFunc will have the code you want to excecute on triggered action, in this action trigger is timer based and can be setup using cron job expression.

