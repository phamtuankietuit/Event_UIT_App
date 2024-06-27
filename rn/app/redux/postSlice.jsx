import { createSlice } from "@reduxjs/toolkit"

const postSlice = createSlice({
  name: "post",
  initialState: {
    selectedImages: [],
    postContent: "",
  },
  reducers: {
    addImages: (state, action) => {
      state.selectedImages.push(...action.payload)
    },
    removeImage: (state, action) => {
      state.selectedImages = state.selectedImages.filter(
        (image) => image !== action.payload
      )
    },
    setPostContent: (state, action) => {
      state.postContent = action.payload
    },
  },
})

export const { addImages, removeImage, setPostContent } = postSlice.actions
export default postSlice.reducer
