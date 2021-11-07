# Design Pattern Sample
Design Pattern 一詞最早出現在 Gof (Gang of Four, GoF) 的著作中, 在軟體設計的領域中, 針對反覆出現的問題所歸納出的解決方法.

設計模式一共有23種, 依照性質又可以分成三大類:

| Creational Pattern    | Structural Pattern    | Behavioral Pattern
| :------               | :------               | :------
| Factory Method        | Adapter               | Interpreter
| Abstract Factory      | Bridge                | Template Method
| Builder               | Composite             | Command
| Protype               | Decorator             | Iterator
| Singleton             | Facade                | Mediator
|                       | Flyweight             | Memento
|                       | Proxy                 | Observer
|                       |                       | State
|                       |                       | Strategy
|                       |                       | Chain of Responsibility
|                       |                       | Visitor

***

# A. Facade

為複雜的系統定義一個介面, 呼叫端透過這個介面操作, 可降低呼叫端對複雜系統的依賴也可以更容易地使用該複雜的系統.

# B. Adapter

將既有類別的介面轉成另一種介面, 然原本不能一起工作的類別因為有共同的介面而可以共同工作. 實務上可能碰上既有類別來自第三方函式庫, 該類別無法變更介面或是更本就沒有介面.

# C. Singleton

確保只有單一實例存在.


# D. Factory Method

定義一個介面, 產生實例的工作交由該介面的實作類別執行, 外部由此介面獲得實例, 可降低外部對實作類別的耦合度. 根據實作方式又可以分為參數化的 Simple Factory 及泛型化的 Generic Factory.

其中 Simple Factory 因為有分支的問體, 可以選擇用資源搜尋法或是 Attribute 的方式決定要建立哪種實作類別的實例. 實作方式又可以選擇 Enum 對應 Type 或是 Enum 對應 Constructor Delegate.