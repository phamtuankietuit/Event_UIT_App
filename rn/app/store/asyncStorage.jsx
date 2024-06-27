import { ToastAndroid } from "react-native"
import AsyncStorage from "@react-native-async-storage/async-storage"

const showToastWithGravity = (msg) => {
  ToastAndroid.showWithGravity(
    msg || "error",
    ToastAndroid.SHORT,
    ToastAndroid.CENTER
  )
}

// STUDENT
export const getIsStudentLogin = async () => {
  try {
    const isStudentLogin = await AsyncStorage.getItem("isStudentLogin")
    return isStudentLogin
  } catch (error) {
    showToastWithGravity("Error getIsStudentLogin: " + error.message)
  }
}

export const setIsStudentLogin = async (isStudentLogin) => {
  try {
    await AsyncStorage.setItem("isStudentLogin", isStudentLogin)
  } catch (error) {
    showToastWithGravity("Error setIsStudentLogin: " + error.message)
  }
}

export const getStudentAccessToken = async () => {
  try {
    const studentAccessToken = await AsyncStorage.getItem("studentAccessToken")
    return studentAccessToken
  } catch (error) {
    showToastWithGravity("Error getStudentAccessToken: " + error.message)
  }
}

export const setStudentAccessToken = async (studentAccessToken) => {
  try {
    await AsyncStorage.setItem("studentAccessToken", studentAccessToken)
  } catch (error) {
    showToastWithGravity("Error setStudentAccessToken: " + error.message)
  }
}

// UNIT
export const getIsUnitLogin = async () => {
  try {
    const isUnitLogin = await AsyncStorage.getItem("isUnitLogin")
    return isUnitLogin
  } catch (error) {
    showToastWithGravity("Error getIsUnitLogin: " + error.message)
  }
}

export const setIsUnitLogin = async (isUnitLogin) => {
  try {
    await AsyncStorage.setItem("isUnitLogin", isUnitLogin)
  } catch (error) {
    showToastWithGravity("Error setIsUnitLogin: " + error.message)
  }
}

export const getUnitAccessToken = async () => {
  try {
    const unitAccessToken = await AsyncStorage.getItem("unitAccessToken")
    return unitAccessToken
  } catch (error) {
    showToastWithGravity("Error getUnitAccessToken: " + error.message)
  }
}

export const setUnitAccessToken = async (unitAccessToken) => {
  try {
    await AsyncStorage.setItem("unitAccessToken", unitAccessToken)
  } catch (error) {
    showToastWithGravity("Error setUnitAccessToken: " + error.message)
  }
}
