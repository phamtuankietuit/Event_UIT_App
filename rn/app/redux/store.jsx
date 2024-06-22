import { configureStore } from "@reduxjs/toolkit"
import postReducer from "./postSlice"
import imageReducer from "./imageSlice"

const store = configureStore({
  reducer: {
    post: postReducer,
    image: imageReducer,
  },
})

export default store
