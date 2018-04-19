module PomParser.Parser

open System.IO
open System.Xml.Linq
open System.Linq

type Info = {
    Version: string
    ArtifactId: string
}

[<CompiledName("Parse")>]
let parse file =
    let content = File.ReadAllText(file: string)
    let root = XDocument.Parse(content).Root
    let all = root.Elements()
    let version = all.First(fun x -> x.Name.LocalName = "version")
    let artifactId = all.First(fun x -> x.Name.LocalName = "artifactId")

    { Version = version.Value
      ArtifactId = artifactId.Value }
