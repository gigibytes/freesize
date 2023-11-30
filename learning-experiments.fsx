#r "nuget: ByteSize, 2.1.1" //add ByteSize package reference
open System
open System.IO

//how to take in a commandline arg?
let main (args) =
    let path = args
    let pathInfo = FileInfo(path)
    let files = Directory.EnumerateFiles(path) //EnumerateFiles vs GetFiles?

    //add up sizes and print
    files |> List.ofSeq |> List.map (fun f -> FileInfo(f).Length) |> List.sum |> printf "the collective file size in the directory %s is %d" path

main fsi.CommandLineArgs[0] //add 'from fsi' when running script