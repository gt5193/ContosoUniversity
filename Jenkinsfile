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
                bat "cd ContosoUniversity.Test"
                bat "dotnet test"
            }
        }
        stage ('Integration Test') { 
            steps() {
                bat "npx cypress run"
            }
        }
        stage ('Deploy') { 
            steps() {
                echo "Deplying something cool!"
            }
        }
    }
}