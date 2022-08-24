## Simple Regex Demo

This is a demo project inteded to demonstrate how regex can be used inside of .Net

---

### Projects

- SimpleValidation
  - Shows how you can use the `RegexStringValidator` class to quickly validate an input string
  
- Matches
  - Shows some simple setup for using the `Regex` class to match an input string
    - How to get results using:
      - The `IsMatch` method
      - The `Matches` method and `MatchCollection` class
      - The `Match` method and `Match`class
      - The properties of the `Match` class

- Groups
  - Shows some simple setup for using the `Regex` class to match an input string
    - How to get results using:
      - The `Groups` property on the `Match` class
      - The `GroupCollection` class
      - The `Group` class

- Evil / Evil_Email
  - How a bad regex pattern can be abused to cause a program to lock up for an exponential amount of time
  
- Evil_Password
  - How allowing user input when regex is involved can be a bad idea (and cause a program to lock up for an exponential amount of time)
