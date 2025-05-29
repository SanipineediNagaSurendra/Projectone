pipeline {
     agent any

     stages{
       stage('Build')
       {
            steps
            {
               echo 'Buildjob sucessfully executed....'
               bat 'dotnet build'
            }
      }
      stage('Test')
           {
              steps
               {
                    echo 'Testjob sucessfully executed...'
                    bat 'dotnet test'
                }
            }
           stage('Deploy')
          {
               steps
                {
                   echo 'Deployjob sucessfully executed...'
                   bat 'dotnet deploy'
                }
          }
   }
}
