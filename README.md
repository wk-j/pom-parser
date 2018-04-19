## POM Parser

```bash
dotnet add package wk.PomParser
```

## Usage

```fsharp
open PomParser

let project = "resources/pom.xml"
let info = Parser.parse(project)
Assert.Equal("export-service", info.ArtifactId)
Assert.Equal("18.4.0", info.Version)
```