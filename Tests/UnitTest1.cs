using System;
using System.Diagnostics;
using System.IO;
using Xunit;
using Xunit.Abstractions;

public class Base64EncoderTests
{
  private readonly ITestOutputHelper _output;

  public Base64EncoderTests(ITestOutputHelper output)
  {
    _output = output;
  }

  [Fact]
  public void EncodeAndDecode_RandomBytes_EncodesAndDecodes()
  {
    Program.Main
  }
}
