pipeline {
    agent any
    environment {
        NUGET_KEY = credentials('NugetFabricam')
    }
    stages { 
        stage ('Build') { 
            steps() {
                bat "dotnet build --configuration Release"
            }
        }
        stage ('Unit Test') { 
            steps() {
                bat "dotnet test"
            }
        }
        stage ('Deploy Nuget Package') {
            steps() {
                bat "dotnet nuget push ContosoUniversity.Api.Client/bin/Debug/*.nupkg -k $NUGET_KEY -s https://api.nuget.org/v3/index.json"
            }
        }
        stage ('Deploy') { 
            steps() {
                echo "Deploying something cool!"
            }
        }
    }
}