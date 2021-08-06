using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace WongaSender
{
    /// <summary>Class <c>Messaging</c> for sending a messaging in JSON-format to the Wonga Application
    /// </summary>
    ///
    class Messaging
    {
        private String name;
        private String queueName = "WONGA_QUEUE";
        public Messaging(String senderName)
        {
            this.name = senderName;
        }

        public bool Initiate()
        {
            if (this.name == null)
            {
                Console.WriteLine("You needed to place your name to send a message\nOooops!!!");
                return false;
            }
            ConnectionFactory factory = new ConnectionFactory();

            factory.Uri = new System.Uri("amqp://guest:guest@localhost:8000");

            IConnection connection = factory.CreateConnection();
            var f = connection.CreateModel();
            f.QueueDeclare(this.queueName, durable: true, exclusive: false, autoDelete: true, arguments: null);

            byte[] dataToSend = Encoding.UTF8.GetBytes(this.name);
            String outputMessage = "Hello, my name is " + this.name;
            //Display message before Sending name of the user
            Console.WriteLine(outputMessage);
            Console.WriteLine("We will make sure your name is sent.\nThank you for using our services.");

            //Send the data to the Platform
            f.BasicPublish("", this.queueName, null, body: dataToSend);

            f.Abort();

            return true;
        }
    }
}
