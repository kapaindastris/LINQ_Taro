# 🎴 LINQ_Taro WPF Application 🎴

**LINQ_Taro** — WPF-приложение для тасовки карт Faro! 💫

---

## 🎯 О проекте

LINQ_Taro позволяет:
- 🔀 **Перемешивать** карточки случайным образом  
- 🔤 **Сортировать** их по алфавиту (по полю `Name`)  
- 🔄 **Сбрасывать** порядок к изначальному  
- 🔍 **Искать** карту по названию  
- 📋 **Просматривать** текущий порядок в ListBox  

Реализовано по шаблону **MVVM** с использованием **LINQ**.

---

## 🚀 Фичи

- **Инициализация** списка из 10 карт (Туз, Двойка, …, Десятка)  
- **Shuffle** через `OrderBy(c => rnd.Next())`  
- **Sort** через `OrderBy(c => c.Name)`  
- **Reset** к исходному списку  
- **Search** через `Where(...)`  
- Реактивный UI благодаря `ObservableCollection<T>` и `ICommand`  

---

## 📂 Структура проекта

```text
LINQ_Taro/
├── Models/
│   └── Card.cs            – модель карточки
│
├── ViewModels/
│   └── MainViewModel.cs   – вся логика и команды
├   └── RelayCommand.cs    – универсальная реализация ICommand
│
├── Views/
│   ├── MainWindow.xaml    – интерфейс
│   └── MainWindow.xaml.cs – пустой code-behind
|
├── App.xaml              – настройки приложения
└── App.xaml.cs           – пустой файл приложения
```
---

## 🔧 Установка и запуск

1.Клонируйте репозиторий:
  ```bash
   git clone https://github.com/yourusername/CardShuffle.git
```
2.Откройте CardShuffle.sln в Visual Studio 2019/2022.

3.Постройте проект (Build → Build Solution).

4.Запустите (F5 или Debug → Start Debugging).

---

## ▶️ Использование

* В поле поиска введите часть названия карты и нажмите “Поиск” 🔍
* Нажмите “Перемешать” 🔀 для случайного порядка
* Нажмите “Сортировать” 🔤 для упорядочивания по алфавиту
* Нажмите “Сброс” 🔄, чтобы вернуть исходный порядок
* Текущий порядок отображается в списке карт

---

## 🛠 Технологии

* .NET 8.0
* WPF (Windows Presentation Foundation)
* C# 8.0
* MVVM pattern
* LINQ

---

## 📄 Лицензия

MIT License.
