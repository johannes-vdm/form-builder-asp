namespace webapi.Models
{
  public class Form
  {
    public List<InputType> InputTypes { get; set; }

    public Form(List<InputType> inputTypes)
    {
      InputTypes = inputTypes;
    }
  }
}
