# LatexDocGen
This is an attempt to make a user friendly LaTeX editor. The main ideas are:
  - Use "blocks" that represent different LaTeX commands.
  - Change the document structure by moving "blocks" with drag and drop
  - Let "blocks" be customizable and expandable(as in, adding new "blocks")

##### What are those "Blocks"?
Blocks are objects that represent a given set of commands in LaTeX, for example:
   - A block named "section", represents the "\section" command. And by moving one section block above another one, the content of those sections would also move, effectively moving the whole section.
   - A block named "list", represents the "{itemize}" enviroment. It holds a list of values that will become "items" when the file is generated.
