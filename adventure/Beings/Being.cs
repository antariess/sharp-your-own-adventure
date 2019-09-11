using System;

namespace adventure {
  abstract class Being {
    public string Name { get; set; }
    public int Health { get; set; }

    public Being (string name) {
      Name = name;
    }

    virtual public void speak (string phrase) {
      Console.WriteLine(phrase);
    }
  }
}