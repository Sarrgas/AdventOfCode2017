pipeline {
  agent any
  stages {
    stage('Checkout'){
      checkout scm
    }
    stage('Build') {
      steps {
	bat "nuget restore \"/01/Inverse Captcha/InverseCaptcha.sln\""
	bat "\"${tool 'MSBuild'}\" \"/01/Inverse Captcha/InverseCaptcha.sln\" /p:Configuration=Release /p:Platform=\"Any CPU\""
      }
    }
  }
}
