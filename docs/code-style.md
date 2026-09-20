# SCSS Property Sorting

Set structure properties first and then appearance and animation properties later.

```scss
.card {
    /* Position */
    position: relative;
    top: 0;
    /* Display */
    display: flex;
    flex-direction: column;
    /* Size */
    width: 300px;
    height: 200px;
    /* Spacing */
    margin: 16px;
    padding: 12px;

    /* Appearance */
    background: white;
    border: 1px solid #ccc;
    border-radius: 8px;
    /* Typography */
    font-size: 16px;
    font-weight: 600;
    color: black;

    /* Animation */
    transition: 0.2s;
}
```

# SCSS Class Sorting
```
.sidebar {
    display: flex;
    width: 250px;
    padding: 16px;

    &__title {
        font-size: 24px;
    }

    &__item {
        padding: 8px;
    }

    &:hover {
        background: #eee;
    }

    &--collapsed {
        width: 60px;
    }
}
```
