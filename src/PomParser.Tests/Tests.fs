module Tests

open Xunit
open PomParser.Parser

[<Fact>]
let ``My test`` () =
    let project = "../../../../../resources/pom.xml"
    let info = parse(project)
    Assert.Equal("export-service", info.ArtifactId)
    Assert.Equal("18.4.0", info.Version)
