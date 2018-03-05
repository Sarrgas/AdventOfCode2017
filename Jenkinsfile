pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
	bat "\"${tool 'MSBuild'}\" "/01/Inverse Captcha/InverseCaptcha.sln" /p:Configuration=Release /p:Platform=\"Any CPU\""
      }
    }
  }
}
