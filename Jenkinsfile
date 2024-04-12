pipeline{
  agent any
  stages{
    stage('checkout'){
      checkout scm
    }
    stage('Build'){
      sh 'dotnet build Build_Test_Jenkins/Build_Test_Jenkins.csproj --configuration Release'
    }
    stage('Test'){
      sh 'dotnet test TestProject1/TestProject1.csproj'
    }
  }
}
