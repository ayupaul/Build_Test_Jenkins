pipeline{
  agent any
  stages{
    stage('checkout'){
      steps{
        checkout scm
      }
    }
    stage('Build'){
      steps{
        sh 'dotnet build Build_Test_Jenkins/Build_Test_Jenkins.csproj --configuration Release'
      }
    }
    stage('Test'){
     steps{
        sh 'dotnet test TestProject1/TestProject1.csproj'
     }
    }
  }
}
