pipeline {
    agent { 
      label 'master'
    }

    stages {
	
	stage('Build') {
	    steps {
		script {
		  echo 'Building..'
		  echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
          	  def msbuild = tool name: 'MSBuild v4', type: 'hudson.plugins.msbuild.MsBuildInstallation'
          	  bat "${msbuild} \"01/Inverse Captcha/Inverse Captcha.sln\" /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
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
