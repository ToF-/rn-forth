create romans 10 allot


: init-romans
  0 romans c! ;

: c>romans ( c -- )
  romans dup c@ 1+
  2dup swap c!
  + c! ;

: decimal>roman ( u -- )
  init-romans
  dup 30 = if
    10 / 0 do
      [char] X c>romans
    loop
  else
    0 do
      [char] I c>romans
    loop
  then ;

