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

為複雜的系統定義一個抽象, 呼叫端透過這個抽象操作, 可降低呼叫端對複雜系統的依賴也可以更容易地使用該複雜的系統.


# B. Adapter

將既有類別的抽象轉成另一種抽象, 讓原本不能一起工作的類別因為有共同的抽象而可以共同工作. 實務上可能碰上既有類別來自第三方函式庫, 該類別無法變更抽象或是更本就沒有抽象.


# C. Singleton

確保只有單一實例存在.


# D. Factory Method

定義一個抽象, 產生實例的工作交由該抽象的實作類別執行, 外部由此抽象獲得實例, 可降低外部對實作類別的耦合度. 根據實作方式又可以分為參數化的 Simple Factory 及泛型化的 Generic Factory.

其中 Simple Factory 因為有分支的問體, 可以選擇用資源搜尋法或是 Attribute 的方式決定要建立哪種實作類別的實例. 實作方式又可以選擇 Enum 對應 Type 或是 Enum 對應 Constructor Delegate.

其中 Generic Factory 由外部直接傳入 AssemblyName 及 TypeName, 因其已經暴露太多訊息, 故實務上比較少用到, 另外 Generic Factory 可用來自建 DI 容器.


# E. Abstract Factory

針對一整族相關的物件定義抽象, 外部透過該抽象取得一整族物件, 而不需要指定他們的型別, 適用於整族切換.

產品的一般化依照垂直關係定義抽象(從屬關係), 如手機與充電器.

工廠的一般化依照水平關係定義抽象(非從屬關係), 如第一世代與第二世代.


# F. Template Method

在抽象中定義操作步驟, 步驟的具體邏輯遞延到子類別, 如此可以再不改變步驟的前提下, 改變具體邏輯.


# G. Strategy

實作類別實作同一個抽象, 操作時透過抽象操作, 從而使得實作的邏輯由外部傳入, 繼而達成可以任意替換的目標.

# H. Chain Of Responsibility

將處理邏輯封裝成物件, 並依業務邏輯組成鏈, 需要處理的需求依照此鏈傳遞, 直到鏈中的物件處理需求為止, 透過這樣的方式可以避免需求發送端與處理端的耦合.

鏈太長會有效能問題偵錯也會更為困難, 但比起巢狀判斷式仍然簡單許多.


# I. State

讓物件自己決定狀態的轉變, 而非由外部進行判斷後再改變其狀態, 由此降低複雜度.

    狀態模式要處理的是, 自己就知道要怎麼改變的話, 就不要由外部告知. 
    責任鏈模式是處理內部就知道動作的處理流程的話不要由外部告知. 
    策略模式則是處理上述, 內部未知狀況之不確定性. 