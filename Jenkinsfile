pipeline {
    agent any
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
        stage ('Integration Test') { 
            steps() {
                dir("${workspace}/ContosoUniversity.Test") {
                    bat "npm install cypress"
                    bat "npx cypress run"
                }
            }
        }
        stage ('Deploy') { 
            steps() {
                echo "Deplying something cool!"
            }
        }
    }
}