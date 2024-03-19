Sometimes when debugging you need to see if a third-party service outside of your control is actually calling an executable and what the arguments are. This is a simple way to do that.

Download the realease which is self contained for windows x64 and rename the exe to anything. It will output an "args.log" file alongside the exe with the arguments it was called with each time it is run.