namespace AdventOfCode

module ProblemTwo =

    let partOneData = """
kqzxdenujwcsthbzgvyioflcsp
vqwxdenujwcsthbmggyioflarp
kqzxienujwcsthbmglyioclarp
kuzxdetujwcsthbmgvyioflcrp
kqnxdenujwcsthbmgvlooflarp
kqzxdknpjwcsthwmgvyioflarp
kgzxdenujwcsthbfgvyicflarp
kqzxdenujrnsthbmgjyioflarp
lqzxdeeujwcsthbmrvyioflarp
iqfxdenujwcsthbmgvyiofyarp
kvzxbenujwcstabmgvyioflarp
kmzxdenujwcsthbmglyioolarp
kqzxdenujhcsthbmgbyioflanp
nqzxdenujwcsehbmgvsioflarp
kqzlgenujwcsthbmgvyiofjarp
kqzxdyfujwcsihbmgvyioflarp
kqzxdsnujwcqthbmgvyiorlarp
kqzxdenuywcsthbmgvyinflmrp
knzxderujwcsthbmgvyioflaop
kqxxdenujwczthbmgvyioflajp
kqzxdevujwcsthbmgvyqoxlarp
kqzxdenujwclmhbmgvyioslarp
kqzldenujwcsthbmgvnisflarp
kjtxdenujwcsthbmgvyfoflarp
kqzxwenujwcstxbmgvyihflarp
kqzxdenuhecsthbmgvyeoflarp
kqzxdenhjwesthbmgvyioklarp
kqkxdenujwcsthbcgvyiofgarp
kqyxmenujwcsthbmgvyioflara
kqzxdqnrjwcwthbmgvyioflarp
kqzxdenufwcgyhbmgvyioflarp
lqzxdenujwcsthbmtvyiofearp
kqzxdenujwcsthbvgvthoflarp
kqzxeenujwcsahbmgvyioflamp
pqzxdenujwcsshbmjvyioflarp
kqzxdesujwcstdbmgvyioflatp
kqzxpenujwcsthimgvyioflhrp
kqzxdmkujwcsthbmgvpioflarp
kszxdenujwcsthbybvyioflarp
kqzxdvnujwcsthbmgvyqoslarp
kkzxdetujwcsthbmgvyiofltrp
kqzxdenujwcsthomgvyiozlaro
cqzfdenubwcsthbmgvyioflarp
kqzxdenyjwcsthbmhvyiofldrp
kqzxdenujwcsthbmghfiofxarp
kmqxdebujwcsthbmgvyioflarp
kqzxdenufwcsthbmvvypoflarp
kqnxdenujwcsthbmgvtzoflarp
bqzxdenujwcithbmgvyiohlarp
kqzxdenurwrsthbmgvyioelarp
kqzxdenujwcsthbmgpyiodlarl
kqzxdengjwcxthbmgvjioflarp
kizxdenujwcsnhqmgvyioflarp
jqzxdenajwcsthbmnvyioflarp
kqzcdenujwcsphbigvyioflarp
kezxdenujwcsthbfgvyioflaqp
kqzxdenujwcstybmgvyivfyarp
kqzxdenujwcsthbmgvbiofsnrp
kqzxdenujwcsthbmgvyhxfnarp
kvzxdenqjfcsthbmgvyioflarp
kqzxywnljwcsthbmgvyioflarp
kqzxdenujwcsbhbzgvyioxlarp
kqkxdenufwcsthbmgvyiofxarp
dqzxddnujwcsthsmgvyioflarp
yqrxdenujwcsthbagvyioflarp
kqzxdenujwcsajbmgvyiovlarp
kqztdunujwcsthbmgvyioilarp
kqzxdequjwcsthbmgvyyoflarm
kqzxdlnujwksthbmgvkioflarp
tqvxdenujwcsthbmgveioflarp
kqzndezupwcsthbmgvyioflarp
kqzctsnujwcsthbmgvyioflarp
kqzxdenujwmstkbmgvyioflgrp
kqzxdenujwzsthdmgvyiofdarp
kqzxdynujwcsthcmgvyioflasp
kqzxdesujwcstybmgcyioflarp
kqzxdenujwcsthbvgvyiyglarp
kqzxpenujwcsthbogvyioflard
khzxdenujwcsthbmgvyikflaep
kqzxdedujwchthbmgvyeoflarp
kxzxsepujwcsthbmgvyioflarp
xqzxdenujwcsthbpgvyioelarp
jfzxdenujwcsthbmgvyiollarp
kqzxcenujwcethbmgvwioflarp
kqzxdenujwcithbmgvysoflarg
kqlxdenujwnsthbmgvyiotlarp
wqzydenujwcsthbmgvyioftarp
kqzxienuwwcsthbmgayioflarp
kqzxdetujwcsthbmgvyhoflawp
kqzxdqnujwrsthbmgvyxoflarp
kqzxdenujwcvthbmgjiioflarp
kqzxdenujwcjthbxgvaioflarp
kqzxpenujwcsthymgvyioklarp
kqzxdenujwcsthbmswygoflarp
kqzxdenujwcsthbmgvyiaxiarp
kqzxdenudkcsthbmgvyzoflarp
kqzxdvndjwcsthbmgvyioflaxp
kqzxdenujwcsthbmdvymoflvrp
kqzxvenujwcsihbmgvyiofllrp
kqzxdqnujwcsthbmgtyioflprp
kqzxdenuuwcathbmgvsioflarp
kqzrdenujwesthbjgvyioflarp
kqzxdexujwcstzbmgvyyoflarp
kqzxpenujwjstabmgvyioflarp
kozxdenejwcsthbmgvpioflarp
kbzxdenvjwcsthbmgvyiofsarp
kolxdenujwcjthbmgvyioflarp
kqzxdenujwcsthbmgvyiffsakp
kqzxdelujwcsthbmlvyioflxrp
kqzxdenugwcsthrmgvyioflprp
kqzxdelujwcsthqmgvyiozlarp
kqzxienujwosthbmgvykoflarp
kqzxdeuujwicthbmgvyioflarp
kqzxdenbjwcsthbmcvyaoflarp
krzxdqnujwcsthbmgvyioflerp
wqzxzenujwcsthbmgvyioclarp
kqzxyenujwcsthbmgejioflarp
kqzxdenujwcstsbmgvtidflarp
kqnxdenejwcsthbmgvyioflara
kqzsdmnujwcsthbmgvyioflaep
kqzxdedujwnsthymgvyioflarp
kqzxdenujwusthbmgnyioflarx
kqzxlenujwcsthbmgayvoflarp
kqzxdenujwcsthbmgvyiofngrh
zqzxdenujwcsthbmgvyiofvxrp
kqzydenujwmsthbmgvyiuflarp
kqzxdenujkrsthbmdvyioflarp
kqzxdlnujocsthbmgvyiofaarp
kqzxdenujwcstybmgvyiofrwrd
kqzxdenupwksthbmgvyiofbarp
khzxdentjwcsthbmbvyioflarp
kqzxdenujwcuphbmgvyihflarp
kqzxdenhjwcgthbmgvyioflrrp
kqzxdenujwcsthbmgvyiofakhp
kqzxdenujwcstfkmgvyioflamp
kqzxdenujqcsthbmgvkiorlarp
kqzxdenujwcstvbmgvyioilasp
kqzxdxnujwcsthbpgayioflarp
kqzxdenupwysthbmgvyiofljrp
kqzxdenujwcdthbmgvymoflarv
kqnxdenujwcstvbmgvyixflarp
kqjxdenujwcsthbmgvyikflurp
kqsxdenulwcsthxmgvyioflarp
bqzxbenujwcsahbmgvyioflarp
vqzxdenujwcsthbmgvjzoflarp
kqzhfenujwcsthimgvyioflarp
eqzxdenujwcshhbmgnyioflarp
kqzxdenujucstubmgvyicflarp
kuzxdenuewcsthbmgvyiofuarp
kqzxdenulwcsthbmgpyigflarp
kqzxdebujwcsthbmgoyioflaro
kqzxdenujwcuthbmgucioflarp
kqzxdenujwcschpmgvyioflhrp
kqzxfenujwcsthbmjvrioflarp
kqzxdenujqcsthbmgvyndflarp
kqzxdgnbjwcsthbmgvywoflarp
kqzxdenujwcsthrmgtbioflarp
yqzxdenyjwcsthbmgvyioflarg
kqzxdenuxwxsthbmsvyioflarp
kqzxdenujwcsthbugqyvoflarp
qqzxdenujwcsahbmgoyioflarp
kqsxdenudwcsthbmguyioflarp
kqzxdenujwcstublgvyioflamp
kqzxdemujwtstqbmgvyioflarp
kqzxqvnajwcsthbmgvyioflarp
kqzxoennjwcstbbmgvyioflarp
kqzxfenujwcsthbmlvyioflwrp
kqzjdunujwcsthhmgvyioflarp
kqzxdenujwcqthbmgvyirfxarp
kqzxdengjwcsthbmgvyiowlgrp
kqgxdenujwcswhbmglyioflarp
mqzxdekuuwcsthbmgvyioflarp
kqzxdenujwdsthbmgbyiovlarp
krzxdenlhwcsthbmgvyioflarp
kqzxdenmjwcstqbmgvyioflanp
kqzxdenujwcmthbmgvtioflyrp
kqzxdenujwcsthbmgvaijflprp
kqzxdenuywysqhbmgvyioflarp
kqzxdenujwfsthbmgvyhoflark
nqzcdefujwcsthbmgvyioflarp
kqzxdenujrcsthgmgyyioflarp
kqzxdqnujwzsthbmgvyioftarp
kqzxdenujwcsthimgvyioolapp
kqzxdenupwcsthbmggyioflyrp
kqzxdjnujwcsthbvgvyioflarf
kqzxdtnujwasthbmgvyiofuarp
kqzxbensjzcsthbmgvyioflarp
kqzxdenujwcsphbmwiyioflarp
kqzgdenuowcsthbmgvyioflarh
kmzxdenujwasthbmgvtioflarp
kqzxdenujwcstybmgvyiofrard
vqzxdenejwcsthbmglyioflarp
kqhxdenujwcsmhbmgvyioflprp
kqzxdnnujwcsthzsgvyioflarp
kczxdenujwcsthbmgvyeoflaop
kqzxdenujwcsxhbmgvaioflaap
kqzxdenujwcsthbmgayiofnprp
kqzxdvnujwcsthbmgvyipjlarp
kqzxdenubwcskhbmgvyiofkarp
kqzxdenujwcsthbgggyigflarp
kqzxdenujncstabvgvyioflarp
kqzxdenujwcstqimqvyioflarp
kqzxeenujwcsdhbmgvyqoflarp
kcpxdenujwcsthbmgvyioilarp
kqwxuenujwcsthbmgvyiyflarp
kqzxdwnujwcstgbmgvyioplarp
kqzxdenuswcstvbmglyioflarp
kqzxdenujwcsthabgvyiwflarp
kqzxdpnujwcsthbmwvyiomlarp
kqzxdenujwcdthbmgvcioffarp
kqzxdenajwcsthbmtvyiofldrp
kqzbnenujwcshhbmgvyioflarp
kqzbdequiwcsthbmgvyioflarp
kqzxdenuswcsohbmgzyioflarp
kvzxdenujwcstdbmjvyioflarp
kqzxoenujwcqthbmpvyioflarp
kqzxhenujwcsthbmgoyiofoarp
klzxdenujwczthbmgvyioflanp
kqpxdenujwcsthbmgvyioflafz
kqkxdenujwcstxbngvyioflarp
kqzepenuxwcsthbmgvyioflarp
bqzxdenujmcithbmgvyioflarp
kdzxdjnujwcstnbmgvyioflarp
kszxdenujwcsthbmgeyiofrarp
kqzxdenijwcsthbmgvhiaflarp
kqzadenujwcbtxbmgvyioflarp
kqkxwenujwcsthbmgvyiowlarp
pqzddenujwcsthbmgvyboflarp
kqzxxenujwcsthbwgvyioflmrp
kqzxdjnujwcsthbmgvyipilarp
pqzxdenujwcsthbmgvyieflark
sqzxdenujtcsthbmgiyioflarp
kqzxdznujwcsthbmgvzioflajp
kqzxdrnujqcsthbmgvyiofvarp
gqzxdenujwcsthemgvlioflarp
kqzxdenujjcsthbmgvuiofljrp
kqzsdenujmcsthbmggyioflarp
kqzxienujwcsthbmgvaioflaip
kqzxdwnujwcstfkmgvyioflarp
kqzqdenujwcithbmzvyioflarp
kqzxdedpjwcsthbmgvyiofbarp
kqzxdeaujwcbtdbmgvyioflarp
kqzewenyjwcsthbmgvyioflarp
kqzxddnujwcsthbmgyyiofrarp
kqzxdtnujwcsthbmgvyiodlard
kqzxdefujwcsthbmgvyiffwarp
xczxdenujwcsthbmgvyooflarp
kuzxdenujucsthbmgvykoflarp
kqzxtenujwcwthbmgvyioplarp
kqzxdencllcsthbmgvyioflarp
"""

    type private IdInfo =
        {
            Twice : bool
            Thrice : bool
        }

    let increment (map : Map<'k, int>) (k : 'k) : Map<'k, int> =
        match Map.tryFind k map with
        | None -> Map.add k 1 map
        | Some v ->
            Map.add k (v + 1) map

    let toCharacterCount (s : string) : Map<char, int> =
        s.ToCharArray ()
        |> Array.fold increment Map.empty

    let private toIdInfo (m : Map<char, int>) : IdInfo =
        m
        |> Map.toList
        |> List.map snd
        |> List.fold (fun ((twice, thrice) as v)-> function | 2 -> (true, thrice) | 3 -> (twice, true) | _ -> v) (false, false)
        |> fun (twice, thrice) -> { Twice = twice; Thrice = thrice }

    let calculateChecksum (ids : string list) =
        ids
        |> List.map toCharacterCount
        |> List.map toIdInfo
        |> List.map (fun i -> ((if i.Twice then 1 else 0),(if i.Thrice then 1 else 0)))
        |> List.fold (fun (a,b) (c,d) -> (a + c, b + d)) (0,0)
        |> fun (a,b) -> a * b

    let partOne () =
        partOneData.Replace("\r\n", "\n").Split [|'\n'|]
        |> List.ofArray
        |> calculateChecksum
