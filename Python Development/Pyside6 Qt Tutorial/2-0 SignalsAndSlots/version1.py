# version 1 : creating a responsive button

from PySide6.QtWidgets import QApplication, QPushButton

# the slot : respons when something happens
def button_clicked():
    print("You clicked the button")

app = QApplication()
button = QPushButton("Press me")

# clicked is a signal of QPushButton emitted when one clicks on the button
# more info can be found in the documentation
button.clicked.connect(button_clicked)

button.show()
app.exec()