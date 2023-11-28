open System
open System.IO

let path = "/home/gigi/Downloads"

let pathInfo = FileInfo(path)

//printf "the last modified time is %A" pathInfo.LastAccessTime //1st test

//enumerate files in a folder
let files = Directory.EnumerateFiles(path) //EnumerateFiles vs GetFiles?
//yields a seq with strings of file paths for files

//get file sizes for all files in folder
files |> List.ofSeq |> List.map (fun f -> FileInfo(f).Length)
//yields val it: int64 list = [0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 0L; 25L; 10L]

//add up sizes and print
files |> List.ofSeq |> List.map (fun f -> FileInfo(f).Length) |> List.sum |> printf "the collective file size in the directory %s is %d" path
