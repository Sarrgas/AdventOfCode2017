pipeline {
    agent any

    stages {
	
	stage('Build') {
	    steps {
		node('master'){
		  echo 'Building..'
		  echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
		  bat "MSBuild \"01/Inverse Captcha/Inverse Captcha.sln\" /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
		}
	    }
	}
	stage('Test') {
	    steps {
		echo 'Testing..'
	    }
	}
	stage('Deploy') {
	    steps {
		echo 'Deploying....'
	    }
	}
    }
}
