public class IpAndPortParser : MonoBehaviour
{
    // Declare a private variable for the input field
    private InputField inputField;

    void Start()
    {
        // Get the input field component
        inputField = GetComponent<InputField>();

        // Add a listener for the OnValueChanged event
        inputField.onValueChanged.AddListener(ParseIpAndPort);
    }

    // Parse the ip and port values from the input field's text
    public void ParseIpAndPort(string ipAndPort)
    {
        // Split the string at the ":" character to get the ip and port values
        string[] values = ipAndPort.Split(':');
        if (values.Length != 2)
        {
            // Throw an exception if the string is not in the correct format
            throw new Exception("Invalid IP and port format. Expected format: ip:port");
        }

        // Assign the values to the appropriate variables
        ClickSender.ip = values[0];
        ClickSender.port = int.Parse(values[1]);
    }
}
