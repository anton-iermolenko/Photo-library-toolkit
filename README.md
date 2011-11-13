Photo library toolkit
=====================

This tool assists in organizing your photo library by renaming **all files** to their "taken" dates thus keeping everything in chronological order in each of your photo albums.

### New file names convention
Photos and videos will be assigned names according to the following pattern: 
	
	ML<year><month><day>_<hours><minutes><seconds>.<file extension>
	
For example: ML20110101_120115.jpg for a photo taken on January 1st 2011, at 12:01:15 PM

### Supported media formats
* Photos - jpg, png (reads EXIF information or taken date field)
* Video - mov, avi, mp4, 3gp (reads Recorded or Encoded dates)
In case metadata was not provided - falls back to file creation/modification dates and takes the earliest one.

### Additional feature - copy taken dates into file creation/modification propeties
When I encode videos taken on my photo camera they loose their taken dates, so I copy them from original files over into creation/modifications dates. This way autonaming logic can give them proper names later on.

Why do I use it
----------------
* Have videos and photos taken on multiple devices shown together in chronological order when viewing (iPhone and iPad appear to use file names only when sorting)
* Backup taken dates in case metadata gets lost over time (some tools overwrite metadata when rotating/cropping images). This was very important for me with video files, since my photo camera keeps it in creation/modification dates only.