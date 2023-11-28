open System
open System.IO

let path = "/home/gigi/Cloud"

let pathInfo = FileInfo(path)

printf "the last modified time is %A" pathInfo.LastAccessTime //basic test. works on Fedora!