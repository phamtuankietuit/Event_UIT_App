import React, { useState, useEffect } from "react"
import { SafeAreaView } from "react-native-safe-area-context"
import {
  Platform,
  Image,
  Modal,
  Text,
  TouchableOpacity,
  View,
} from "react-native"
import logo from "../../assets/images/Logo.png"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import {
  faAngleRight,
  faArrowRightFromBracket,
  faCamera,
  faXmark,
} from "@fortawesome/free-solid-svg-icons"
import * as ImagePicker from "expo-image-picker"
import { useRouter } from "expo-router"
import Input from "../components/Input"
export default function Profile() {
  const router = useRouter()

  const [openPass, setOpenPass] = useState(false)
  const setClosePass = () => {
    setOpenPass(false)
    setPass("")
    setErrorPass("")
    setNewPass("")
    setErrorNewPass("")
    setPreNewPass("")
    setErrorPreNewPass("")
  }
  //Pass
  const [pass, setPass] = useState("")
  const [errorPass, setErrorPass] = useState("")

  const onChangePass = (value) => {
    setPass(value)
    setErrorPass("")
  }

  //NewPass
  const [newPass, setNewPass] = useState("")
  const [errorNewPass, setErrorNewPass] = useState("")

  const onChangeNewPass = (value) => {
    setNewPass(value)
    setErrorNewPass("")
  }

  //NewPass
  const [preNewPass, setPreNewPass] = useState("")
  const [errorPreNewPass, setErrorPreNewPass] = useState("")

  const onChangePreNewPass = (value) => {
    setPreNewPass(value)
    setErrorPreNewPass("")
  }

  //Image
  const imagePicker = async () => {
    const result = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsEditing: true,
      aspect: [4, 3],
      quality: 1,
    })

    if (!result.cancelled) {
      console.log(result)
    }
  }

  useEffect(() => {
    ; (async () => {
      if (Platform.OS !== "web") {
        const { status } =
          await ImagePicker.requestMediaLibraryPermissionsAsync()
        if (status !== "granted") {
          alert("Sorry, we need camera roll permissions to make this work!")
        }
      }
    })()
  }, [])
  return (
    <View className='flex-1 mt-3'>
      <View className='text-wrap flex flex-row items-center gap-5 px-10'>
        <View className='flex flex-row items-end'>
          <Image
            source={logo}
            className='me-4 h-[100px] w-[100px] rounded-full bg-white '
          />
          <TouchableOpacity onPress={() => imagePicker()}>
            <FontAwesomeIcon icon={faCamera} />
          </TouchableOpacity>
        </View>

        <View className='me-3'>
          <Text className='mb-2 font-semibold'>Ngô Trung Quân</Text>
          <Text>sinh viên</Text>
        </View>
      </View>

      <View className='my-10 px-10'>
        <TouchableOpacity
          className='mb-3 flex w-[100%] flex-row items-center justify-between rounded-xl bg-blue-500 p-3'
          onPress={() => setOpenPass(true)}
          style={{
            shadowColor: "#000",
            shadowOffset: {
              width: 0,
              height: 2,
            },
            shadowOpacity: 0.23,
            shadowRadius: 2.62,

            elevation: 4,
          }}
        >
          <Text className='text-white'>Đổi mật khẩu</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity
          className='mb-3 flex w-[100%] flex-row items-center justify-between rounded-xl bg-blue-500 p-3'
          onPress={() =>
            router.navigate("/(page)/Participation_Event/participation_event")
          }
          style={{
            shadowColor: "#000",
            shadowOffset: {
              width: 0,
              height: 2,
            },
            shadowOpacity: 0.23,
            shadowRadius: 2.62,

            elevation: 4,
          }}
        >
          <Text className='text-white'>Quản lý sự kiện tham gia</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity
          className='mb-3 flex w-[100%] flex-row items-center justify-between rounded-xl bg-blue-500 p-3'
          onPress={() =>
            router.navigate("/(page)/Student_History/student_history")
          }
          style={{
            shadowColor: "#000",
            shadowOffset: {
              width: 0,
              height: 2,
            },
            shadowOpacity: 0.23,
            shadowRadius: 2.62,

            elevation: 4,
          }}
        >
          <Text className='text-white'>Điểm rèn luyện</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity
          className='mb-3 flex w-[100%] flex-row items-center justify-between rounded-xl bg-blue-500 p-3'
          onPress={() =>
            router.navigate("/(page)/Management_Event/management_event")
          }
          style={{
            shadowColor: "#000",
            shadowOffset: {
              width: 0,
              height: 2,
            },
            shadowOpacity: 0.23,
            shadowRadius: 2.62,

            elevation: 4,
          }}
        >
          <Text className='text-white'>Quản lý sự kiện</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity
          className='mb-3 flex w-[100%] flex-row items-center justify-between rounded-xl bg-blue-500 p-3'
          style={{
            shadowColor: "#000",
            shadowOffset: {
              width: 0,
              height: 2,
            },
            shadowOpacity: 0.23,
            shadowRadius: 2.62,

            elevation: 4,
          }}
          onPress={() =>
            router.navigate("/(page)/Report_Page/report_page")
          }
        >
          <Text className='text-white'>Báo cáo thống kê</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity
          className='mb-3 flex w-[100%] flex-row items-center justify-between rounded-xl bg-blue-500 p-3'
          style={{
            shadowColor: "#000",
            shadowOffset: {
              width: 0,
              height: 2,
            },
            shadowOpacity: 0.23,
            shadowRadius: 2.62,

            elevation: 4,
          }}
        >
          <Text className='text-white'>Đăng xuất</Text>
          <FontAwesomeIcon icon={faArrowRightFromBracket} color='white' />
        </TouchableOpacity>
      </View>
      <Modal
        visible={openPass}
        animationType='slide'
        transparent={true}
        onRequestClose={() => {
          setClosePass()
        }}
      >
        <SafeAreaView>
          <View className='h-full bg-white p-3'>
            <View className='flex h-[5%] flex-row justify-between'>
              <Text>Đổi mật khẩu</Text>
              <TouchableOpacity onPress={() => setClosePass()}>
                <FontAwesomeIcon icon={faXmark} className='w-[20%]' />
              </TouchableOpacity>
            </View>

            <Input
              value={pass}
              handleChange={onChangePass}
              placeholder={"Nhập mật khẩu"}
              error={errorPass}
              title={"Mật khẩu"}
              require
              password={true}
            />
            <Input
              value={newPass}
              handleChange={onChangeNewPass}
              placeholder={"Nhập mật khẩu mới"}
              error={errorNewPass}
              title={"Mật khẩu mới"}
              require
              password={true}
            />
            <Input
              value={preNewPass}
              handleChange={onChangePreNewPass}
              placeholder={"Nhập lại mật khẩu mới"}
              error={errorNewPass}
              title={"Mật khẩu mới"}
              require
              password={true}
            />

            <View className='my-2 flex items-center justify-center'>
              <TouchableOpacity className='my-3 flex w-[60%] items-center justify-center rounded-2xl bg-[#3A57E8] px-3 py-3'>
                <Text className='text-white'>Đổi mật khẩu</Text>
              </TouchableOpacity>
            </View>
          </View>
        </SafeAreaView>
      </Modal>
    </View>
  )
}
