# version 2 : signals sending values and captureing values in slots

from PySide6.QtWidgets import QApplication, QPushButton

# the slot : respons when something happens
def button_clicked(data):
    print("You clicked the button : ", data)

app = QApplication()
button = QPushButton("Press me")
# makes the button checkable (toggle checks), unchecked by default
button.setCheckable(True) 

# clicked is a signal of QPushButton emitted when one clicks on the button
# more info can be found in the documentation
button.clicked.connect(button_clicked)

button.show()
app.exec()