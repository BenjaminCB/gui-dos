#r "FsCheck"
open FsCheck

let revRevIsOrig (xs:list<int>)=List.rev(List.rev xs) = xs

