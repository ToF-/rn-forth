create romans 10 allot

: decimal>roman ( u -- )
  1 = if
    1 romans c!
    [char] I romans 1+ c! 
  else
    2 romans c!
    [char] I romans 1+ c!
    [char] I romans 2 + c! 
  then ;
