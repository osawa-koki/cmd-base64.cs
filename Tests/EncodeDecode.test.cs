namespace cmd_base64_cs
{
  public class Base64EncoderTests
  {
    private static readonly int iterations = 100;

    [Fact]
    public void EncodeAndDecode_RandomBytes_EncodesAndDecodes()
    {
      for (int i = 0; i < iterations; i++)
      {
        // ランダムなバイト列を生成
        byte[] originalBytes = new byte[1024];
        new Random().NextBytes(originalBytes);

        // ファイルに書き込み
        string inputFilePath = "test_input.bin";
        string encodedFilePath = "test_encoded.txt";
        string decodedFilePath = "test_decoded.bin";
        File.WriteAllBytes(inputFilePath, originalBytes);

        // エンコードしてファイルに書き込み
        Program.Main(new string[] { "--input", inputFilePath, "--output", encodedFilePath, "--encode" });

        // デコードしてファイルに書き込み
        Program.Main(new string[] { "--input", encodedFilePath, "--output", decodedFilePath, "--decode" });

        // デコードしたバイト列を取得
        byte[] decodedBytes = File.ReadAllBytes(decodedFilePath);

        // 元のバイト列とデコードしたバイト列が一致することを確認
        Assert.Equal(originalBytes, decodedBytes);

        // ファイルの削除
        File.Delete(inputFilePath);
        File.Delete(encodedFilePath);
        File.Delete(decodedFilePath);
      }
    }
  }
}
