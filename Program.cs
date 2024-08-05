using LeetCodeProblems;

var encoded = EncodeDecode.Encode(["!code","6572!!!!","!word","!words"]);

var decoded = EncodeDecode.Decode(encoded);

foreach(var str in decoded){
    Console.WriteLine(str);
}