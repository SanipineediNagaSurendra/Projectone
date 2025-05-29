pipeline {
     agent any

     stages{
       stage('Build')
       {
            steps
            {
               echo 'Buildjob sucessfully executed....'
                bat 'Build job running'
            }
      }
      stage('Test')
           {
              steps
               {
                    echo 'Testjob sucessfully executed...'
                    bat 'Test job running'
                }
            }
           stage('Deploy')
          {
               steps
                {
                   echo 'Deployjob sucessfully executed...'
                   bat 'Deploy job runnig'
                }
          }
   }
}
