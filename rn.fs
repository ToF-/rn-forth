create romans 10 allot


: decimal>roman ( u -- )
  0 romans c!
  0 do
    romans dup c@ 1+ swap c!
    [char] I romans 1+ i + c! 
  loop ;

