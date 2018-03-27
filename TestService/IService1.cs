using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<string> ConvertToArray(string str);
        [OperationContract]
        String ConvertToUpperCase(string str);
        [OperationContract]
        List<MyClass> WordLengths(string str);

        [OperationContract]
        int LengthOfString(string str);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "InClassWCFAssignment01.ContractType".
    [DataContract]
    public class MyClass
    {
        [DataMember]
        public string word { get; set; }
        [DataMember]
        public int length { get; set; }
    }

    

}
