( start with empty to use go.fs )
empty

( tests )
: balanced? depth 0 = -1 = ;
: out_balance balanced? if s" (Balanced? pass)" else s" (Balanced? fail)" endif type ;

( test list )
: test_out out_balance ;

( run test list )
test_out
