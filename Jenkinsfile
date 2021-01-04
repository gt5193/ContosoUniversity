pipeline {
    agent any
    stages { 
        stage ('Build') { 
            steps() {
                bat "dotnet build --configuration Release"
            }
        }
        stage ('Test') { 
            steps() {
                bat "dotnet test \ContosoUniversity\ContosoUniversity.Test.csproj"
            }
        }
        stage ('QA') { 
            steps() {
                echo "QAing something cool!"
            }
        }
        stage ('Deploy') { 
            steps() {
                echo "Deplying something cool!"
            }
        }
        stage ('Monitor') { 
            steps() {
                echo "Monitoring something cool!"
            }
        }
    }
}