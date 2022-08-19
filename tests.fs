require ffl/tst.fs
require rn.fs

page

." given 1 produce string I" cr
t{ 
  1 decimal>roman
  romans count s" I" ?str
}t
." given 2 produce string II" cr
t{ 
  2 decimal>roman
  romans count s" II" ?str
}t
bye
