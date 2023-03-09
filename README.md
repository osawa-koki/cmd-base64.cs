# cmd-base64.cs

🐏🐏🐏 コマンドラインでbase64エンコード/デコードを行うプログラムです。  

## 実行方法

コンパイルするには、以下のコマンドを実行します。

```shell
dotnet publish --configuration Release --output ./bin
```

これで、`./bin`ディレクトリに実行ファイルが生成されます。  

### エンコード

```shell
./bin/base64 --encode --input <エンコード対象ファイル> --output <出力先ファイル>
./bin/base64 --encode --input input.png --output output.txt
```

### デコード

```shell
./bin/base64 --decode --input <デコード対象ファイル> --output <出力先ファイル>
./bin/base64 --decode --input input.txt --output output.png
```

---

テストを実行するには、以下のコマンドを実行します。

```shell
dotnet test ./Tests
```
