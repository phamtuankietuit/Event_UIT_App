import { createSlice } from "@reduxjs/toolkit"

const postSlice = createSlice({
  name: "post",
  initialState: {
    selectedImages: [],
    base64Images: [],
    postContent: "",
  },
  reducers: {
    addImages: (state, action) => {
      state.selectedImages.push(...action.payload)
    },
    addBase64Images: (state, action) => {
      state.base64Images.push(...action.payload)
    },
    removeImage: (state, action) => {
      const index = state.selectedImages.indexOf(action.payload)
      if (index > -1) {
        state.selectedImages.splice(index, 1)
        state.base64Images.splice(index, 1)
      }
    },
    setPostContent: (state, action) => {
      state.postContent = action.payload
    },
  },
})

export const { addImages, addBase64Images, removeImage, setPostContent } =
  postSlice.actions
export default postSlice.reducer
