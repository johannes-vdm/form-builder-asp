using System;

namespace webapi.Models
{
  public class ValidationType
  {
    public int Num { get; set; }
    public string Name { get; }

    public static ValidationType Required => new ValidationType(0, "Required");
    public static ValidationType MinLength => new ValidationType(1, "MinLength");
    public static ValidationType MaxLength => new ValidationType(2, "MaxLength");
    public static ValidationType Range => new ValidationType(3, "Range");
    public static ValidationType EmailFormat => new ValidationType(4, "EmailFormat");
    public static ValidationType PhoneFormat => new ValidationType(5, "PhoneFormat");

    private ValidationType(int num, string name)
    {
      Num = num;
      Name = name ?? throw new ArgumentNullException(nameof(name));
    }
  }

  public class InputValidation
  {

    public ValidationType Key { get; set; }
    public string ErrorMessage { get; set; }

    public InputValidation(ValidationType key, string errorMessage)
    {
      Key = key ?? throw new ArgumentNullException(nameof(key));
      ErrorMessage = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
    }
  }
}
