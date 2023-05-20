using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
  [ApiController]
  [Route("input-types")]

  public class InputTypesController : ControllerBase
  {
    [HttpGet]

    public ActionResult<IEnumerable<InputType>> GetInputTypes()
    {
      var inputTypes = new List<InputType>
      {
        new InputType("Text", new List<InputValidation>
        {
            new InputValidation(ValidationType.Required, "Please enter a value."),
            new InputValidation(ValidationType.MinLength, "Please enter at least 3 characters."),
            new InputValidation(ValidationType.MaxLength, "Please enter no more than 100 characters.")
        }),
        new InputType("Number", new List<InputValidation>
        {
            new InputValidation(ValidationType.Required, "Please enter a number."),
            new InputValidation(ValidationType.Range, "Please enter a number between 1 and 100.")
        }),
        new InputType("Email", new List<InputValidation>
        {
            new InputValidation(ValidationType.Required, "Please enter an email."),
            new InputValidation(ValidationType.EmailFormat, "Please enter a valid email.")
        }),
        new InputType("Phone", new List<InputValidation>
        {
            new InputValidation(ValidationType.Required, "Please enter a phone number."),
            new InputValidation(ValidationType.PhoneFormat, "Please enter a valid phone number.")
        }),
        new InputType("Checkbox", new List<InputValidation>
        {
            new InputValidation(ValidationType.Required, "Please check the box.")
        }),
        new InputType("Radio", new List<InputValidation>
        {
            new InputValidation(ValidationType.Required, "Please select an option.")
        }),
      };

      return Ok(inputTypes);
    }
  }
}

public class InputType
{
  public string Name { get; }
  public List<InputValidation> Validations { get; }

  public InputType(string name, List<InputValidation> validations)
  {
    Name = name ?? throw new ArgumentNullException(nameof(name));
    Validations = validations ?? throw new ArgumentNullException(nameof(validations));
  }
}