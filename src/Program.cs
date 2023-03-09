using CommandLine;

Parser.Default.ParseArguments<Options>(args).WithParsed(RunOptions);

void RunOptions(Options options)
{
  string inputFilePath = options.InputFilePath!;
  string outputFilePath = options.OutputFilePath!;
  bool encode = options.Encode!;
  bool decode = options.Decode!;

  // 指定されたオプションに応じてエンコードまたはデコードを行う
  if (encode)
  {
    EncodeFile(inputFilePath, outputFilePath);
  }
  else if (decode)
  {
    DecodeFile(inputFilePath, outputFilePath);
  }
  else
  {
    Console.WriteLine("Please specify --encode or --decode.");
  }
}

void EncodeFile(string inputFilePath, string outputFilePath)
{
  byte[] bytes = File.ReadAllBytes(inputFilePath);
  string base64 = Convert.ToBase64String(bytes);
  File.WriteAllText(outputFilePath, base64);
  Console.WriteLine("Encoded successfully.");
}

void DecodeFile(string inputFilePath, string outputFilePath)
{
  string base64 = File.ReadAllText(inputFilePath);
  byte[] bytes = Convert.FromBase64String(base64);
  File.WriteAllBytes(outputFilePath, bytes);
  Console.WriteLine("Decoded successfully.");
}

class Options
{
  [Option('i', "input", Required = true, HelpText = "Input file path.")]
  public string? InputFilePath { get; set; }

  [Option('o', "output", Required = true, HelpText = "Output file path.")]
  public string? OutputFilePath { get; set; }

  [Option('e', "encode", Required = true, HelpText = "Encode input file.")]
  public bool Encode { get; set; }

  [Option('d', "decode", Required = true, HelpText = "Decode input file.")]
  public bool Decode { get; set; }
}
