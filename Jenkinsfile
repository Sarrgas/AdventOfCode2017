pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        git 'https://github.com/Sarrgas/AdventOfCode2017.git'
        bat 'nuget restore SolutionName.sln'
		    bat "\"${tool 'MSBuild'}\" SolutionName.sln /p:Configuration=Release /p:Platform=\"Any CPU\""
      }
    }
  }
}
