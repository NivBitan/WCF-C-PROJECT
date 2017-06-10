using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfDuplexServiceInterface;
using WCFDuplexServiceLibrary;

namespace WcfDuplexServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C# Project Duplex Service Host";

            // Step 1 Create a URI to serve as the base address.
            // Ex. "http://localhost:9001/WCFServices/"
            var baseAddress = new Uri("http://localhost:9001/WCFServices/");

            // Step 2 Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(WcfDuplexService), baseAddress);

            try
            {
                // Step 3 Add a service endpoint.
                selfHost.AddServiceEndpoint(typeof(IDuplexService),
                    new WSDualHttpBinding(WSDualHttpSecurityMode.None), "NBADuplexService");

                // Step 4 Enable Metadata Exchange and Add MEX endpoint
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                selfHost.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName,
                    MetadataExchangeBindings.CreateMexHttpBinding(), baseAddress + "mex");

                // Step 5 Start the service.
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Listening at: {0}", baseAddress);
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}


/*
 *  HTTP is connectionless and therefore is a unidirectional protocol, 
 *  therefore WSDualHttpBinding utilizes two HTTP channels in order to support duplex 
 *  communication. For WSDualHttpBinding there is a channel from client-to-service 
 *  and a channel from service-to-client.
 */
