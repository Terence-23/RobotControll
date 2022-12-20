using UnityEngine;
using System.Collections;


public class IpAndPortParser : MonoBehaviour
{

    // Parse the ip and port values from the input field's text
    public void ParseIpAndPort(string ipAndPort)
    {
        // Split the string at the ":" character to get the ip and port values
        string[] values = ipAndPort.Split(':');
        if (values.Length != 2)
        {
            return ;
        }

        // Assign the values to the appropriate variables
        ClickSender.ipAddress = values[0];
        ClickSender.port = int.Parse(values[1]);
    }
}
